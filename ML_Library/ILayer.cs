namespace ML_Library
{
    /// <summary>The interface for a layer of a network.</summary>
    public interface ILayer
    {
        /// <summary>Gets or sets the activation method to use in this layer.</summary>
        /// <value>The activation method.</value>
        ActivationMethod ActivationMethod { get; set; }
        /// <summary>Gets or sets the outputs for this layer.</summary>
        /// <value>The outputs.</value>
        double[] Outputs { get; set; }
        /// <summary>Gets or sets the input count for this layer.</summary>
        /// <value>The input count.</value>
        int InputCount { get; set; }
        /// <summary>Gets or sets the node count for this current layer.</summary>
        /// <value>The node count.</value>
        int NodeCount { get; set; }
        /// <summary>Gets or sets the learning rate for this layer.</summary>
        /// <value>The learning rate.</value>
        double LearningRate { get; set; }

        double[] ForwardPass(double[] inputs);
        double[] Backpropagate(double[] errors);
    }
}
