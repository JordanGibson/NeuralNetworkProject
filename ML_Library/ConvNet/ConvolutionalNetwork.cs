using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ML_Library.ConvNet
{
    public class ConvolutionalNetwork
    {
        public List<BaseLayer> Structure = new List<BaseLayer>();

        public static ConvolutionalNetwork DebugNet { get
            {
                ConvolutionalNetwork network = new ConvolutionalNetwork();
                network.AddConvolutionalLayer(32, 3);
                network.AddPoolingLayer(2);
                network.AddActivationLayer(ActivationMethod.ReLU);
                network.AddConvolutionalLayer(32, 3);
                network.AddPoolingLayer(2);
                network.AddActivationLayer(ActivationMethod.ReLU);
                network.AddConvolutionalLayer(32, 3);
                network.AddPoolingLayer(2);
                network.AddActivationLayer(ActivationMethod.ReLU);
                return network;
                }
            }

        public void AddConvolutionalLayer(int filterCount, int filterSize, int stride = 1)
        {
            Structure.Add(new ConvLayer(filterCount, filterSize, stride));
        }

        public void AddActivationLayer(ActivationMethod activationMethod)
        {
            Structure.Add(new ActivationLayer(activationMethod));
        }

        public void AddPoolingLayer(int poolSize, int stride = 2)
        {
            Structure.Add(new PoolingLayer(poolSize));
        }

        public void AddFlattenLayer()
        {
            Structure.Add(new FlattenLayer());
        }

        public void AddFullyConnectedLayer(int nodeCount)
        {
            Structure.Add(new FullyConnected(nodeCount));
        }

        public void InitialiseNetwork()
        {
            for(int i = 0; i < Structure.Count; i++)
            {

            }
        }

        public Matrix3D ForwardPropagate(Matrix3D inputs)
        {
            Matrix3D outputs = inputs;
            for (int i = 0; i < Structure.Count; i++)
            {
                outputs = Structure[i].ForwardPropagate(outputs);
            }
            return outputs;
        }

        public Bitmap[] BitmapsFromActivations(int layer)
        {
            Matrix3D matrix = Structure[layer].OutputSpace;
            Bitmap[] imageList = new Bitmap[matrix.Depth];
            for (int filter = 0; filter < matrix.Depth; filter++)
            {
                Bitmap bmp = new Bitmap(matrix.Rows, matrix.Cols);
                for (int x = 0; x < bmp.Width; x++)
                {
                    for (int y = 0; y < bmp.Height; y++)
                    {
                        var pixel = Convert.ToInt32(Utility.Clamp(matrix[filter, x, y] * 255, 0, 255));
                        var color = Color.FromArgb(pixel, pixel, pixel);
                        bmp.SetPixel(x, y, color);
                    }
                }
                imageList[filter] = bmp;
            }
            return imageList;
        }

    }
}
