using System;
using System.Collections.Generic;
using Microsoft.ML;
using Microsoft.ML.Data;
using Microsoft.ML.Transforms.Image;

namespace Hompus.BitmapOnnxPrediction
{
    class Program
    {
        public static void Main()
        {
            const string modelLocation = "model.onnx"; // The location of your model

            var mlContext = new MLContext();

            var pipeline = mlContext.Transforms
                .ResizeImages("image", 224, 224, nameof(ImageInputData.Image))
                .Append(mlContext.Transforms.ExtractPixels("data", "image"))
                .Append(mlContext.Transforms.ApplyOnnxModel("classLabel", "data", modelLocation));

            var data = mlContext.Data.LoadFromEnumerable(new List<ImageInputData>());
            var model = pipeline.Fit(data);

            var predictionEngine = mlContext.Model.CreatePredictionEngine<ImageInputData, ImagePrediction>(model);

            var bitmap = MLImage.CreateFromFile("..."); // your source of a bitmap
            var input = new ImageInputData { Image = bitmap };

            var prediction = predictionEngine.Predict(input);

            var classification = prediction.Labels[0];

            Console.WriteLine($"Classified as: {classification}");
        }
    }

    class ImageInputData
    {
        [ImageType(224, 224)]
        public MLImage Image { get; set; }
    }

    class ImagePrediction
    {
        [ColumnName("classLabel")]
        public string[] Labels;
    }
}
