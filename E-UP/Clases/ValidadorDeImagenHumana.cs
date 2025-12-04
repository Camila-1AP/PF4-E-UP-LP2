using Microsoft.ML.OnnxRuntime;
using Microsoft.ML.OnnxRuntime.Tensors;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace E_UP.Clases
{
    internal class ValidadorDeImagenHumana
    {
        private readonly InferenceSession session;
        //private readonly string[] labels = new[] { "person", "bicycle", "car", "dog", "cat", "chair" }; // simplificado
        private readonly string[] labels = new[]
{
    "person","bicycle","car","motorcycle","airplane","bus","train","truck","boat","traffic light",
    "fire hydrant","stop sign","parking meter","bench","bird","cat","dog","horse","sheep","cow",
    "elephant","bear","zebra","giraffe","backpack","umbrella","handbag","tie","suitcase","frisbee",
    "skis","snowboard","sports ball","kite","baseball bat","baseball glove","skateboard","surfboard",
    "tennis racket","bottle","wine glass","cup","fork","knife","spoon","bowl","banana","apple",
    "sandwich","orange","broccoli","carrot","hot dog","pizza","donut","cake","chair","couch",
    "potted plant","bed","dining table","toilet","tv","laptop","mouse","remote","keyboard","cell phone",
    "microwave","oven","toaster","sink","refrigerator","book","clock","vase","scissors","teddy bear",
    "hair drier","toothbrush"
};

        public ValidadorDeImagenHumana(string rutaModelo)
        {
            session = new InferenceSession(rutaModelo);

            /*var session = new InferenceSession("Models/yolov5s.onnx");
            foreach (var input in session.InputMetadata)
            {
                Console.WriteLine($"Nombre de entrada: {input.Key}");
            }*/
        }

        public bool ContienePersona(string rutaImagen)
        {
            Bitmap imagen = new Bitmap(rutaImagen);
            var tensor = Preprocesar(imagen);

            var inputs = new List<NamedOnnxValue>
        {
            NamedOnnxValue.CreateFromTensor("Model::input_0", tensor)
        };

            var resultados = session.Run(inputs);
            //
            var salida = resultados.First().AsEnumerable<float>().ToArray();
            var salidaTensor = resultados.First().AsTensor<float>();
            var dims = salidaTensor.Dimensions;
            Console.WriteLine($"Dimensiones: {string.Join(",", dims.ToArray())}");

            var data = salidaTensor.ToArray();
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine($"[{i}] = {data[i]}");
            }

            int contadorPersonas = 0;

            for (int i = 0; i < salida.Length; i += 6)
            {
                float x = salida[i];
                float y = salida[i + 1];
                float w = salida[i + 2];
                float h = salida[i + 3];
                float confianza = salida[i + 4];
                int clase = (int)salida[i + 5];

                if (confianza > 0.5 && clase == 0 && w > 20 && h > 20)
                {
                    float area = w * h;
                    if (area > 0.05 * (640 * 640)) // más del 5% de la imagen
                        contadorPersonas++;
                }
            }

            return contadorPersonas > 0;

            /*for (int i = 0; i < salida.Length; i += 6)
            {
                float confianza = salida[i + 4];
                int clase = (int)salida[i + 5];

                //if (confianza > 0.5 && labels[clase] == "person")
                if (confianza > 0.75 && labels[clase] == "person")
                    

                return true;
            }

            return false;*/
        }
        private Tensor<float> Preprocesar(Bitmap imagen)
        {
            int ancho = 640, alto = 640;
            Bitmap redimensionada = new Bitmap(imagen, new Size(ancho, alto));
            //var tensor = new DenseTensor<float>(new[] { 1, 3, alto, ancho });
            var tensor = new DenseTensor<float>(new[] { 1, alto, ancho, 3 });

            for (int y = 0; y < alto; y++)
            {
                for (int x = 0; x < ancho; x++)
                {
                    Color pixel = redimensionada.GetPixel(x, y);
                    tensor[0, y, x, 0] = pixel.R / 255.0f;
                    tensor[0, y, x, 1] = pixel.G / 255.0f;
                    tensor[0, y, x, 2] = pixel.B / 255.0f;
                }
            }


            return tensor;
        }

    }
}

