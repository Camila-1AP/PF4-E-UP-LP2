using Microsoft.ML.OnnxRuntime;
using Microsoft.ML.OnnxRuntime.Tensors;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_UP.Modelo
{
    internal class YoloDetector
    {
        private readonly InferenceSession session;

        public YoloDetector(string modelPath)
        {
            session = new InferenceSession(modelPath);
        }

        public bool DetectaPersona(Bitmap imagen)
        {
            var input = PrepararImagen(imagen);

            var inputs = new List<NamedOnnxValue>
        {
            NamedOnnxValue.CreateFromTensor("images", input)
        };
            var resultados = session.Run(inputs);
            try
            {
                var salida = resultados.First().AsEnumerable<float>().ToArray();
                return RevisarDetecciones(salida);
            }
            finally
            {
                resultados.Dispose();
            }
        }

        private Tensor<float> PrepararImagen(Bitmap img)
        {
            Bitmap resized = new Bitmap(img, new Size(640, 640));

            var tensor = new DenseTensor<float>(new[] { 1, 3, 640, 640 });

            for (int y = 0; y < 640; y++)
            {
                for (int x = 0; x < 640; x++)
                {
                    Color color = resized.GetPixel(x, y);
                    tensor[0, 0, y, x] = color.R / 255f;
                    tensor[0, 1, y, x] = color.G / 255f;
                    tensor[0, 2, y, x] = color.B / 255f;
                }
            }
            return tensor;
        }

        private bool RevisarDetecciones(float[] output)
        {
            int atributosPorDeteccion = 85;  // x1,y1,x2,y2,conf + 80 clases
            int detecciones = output.Length / atributosPorDeteccion;

            for (int i = 0; i < detecciones; i++)
            {
                float confianza = output[i * atributosPorDeteccion + 4];

                if (confianza < 0.40f)
                    continue;

                var clases = output
                    .Skip(i * atributosPorDeteccion + 5)
                    .Take(80)
                    .ToArray();

                int claseID = Array.IndexOf(clases, clases.Max());

                if (claseID == 0) // PERSONA = clase #0 en COCO
                    return true;
            }

            return false;
        }
    }
}
