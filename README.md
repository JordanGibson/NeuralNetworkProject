# Neural Network Project
This is a project showcasing a neural network, written using no 3rd party matrix or ML libraries.
Within the project, there is the functionality to create a new Neural Network with a custom design with the controllable parameters:
- Learning rate
- Activation method
- Node count

This gives complete customizablility with the network structure. There was progress made with a convolutional network being implemented - but is not included in this release as time taken to train it is too long.
The best example to test the software with is the XOR problem. A good example net to test with is a structure of:
- 8 nodes, Tanh activation, 0.7 learning rate
- 1 node, Tanh activation, 0.3 learning rate

In the results, this neural network algorithm has also been applied to the MNIST problem, with a different network structure, and proved to have a good success rate, and show substantial learning.

# Installing

Clone this repository to your local machine.
Open this directory in Visual Studio, and set SandboxUI as the startup project.
Go to Debug > Start Debugging and the XOR window should launch.

# Testing locally

To test the neural network locally, click New Network, and fill out the network structure as described above - or similar.
Train the algorithm for 2000 iterations. There should be good evidence of learning by this stage.
If not, continue to train the network until there is. This can occur because there is a random distribution of weights at the beginning and the weights may be too extreme, or the network configuration may not be efficient / complex enough.

# Testing Results

When testing the XOR problem, there was a significant decrease in the loss function, as shown below, showing that learning is occurring.

![ image](https://drive.google.com/uc?export=view&id=1_eTtAxZcWk_wTubd7VLoBccsWLrZ5sL5)

After only 500 iterations, it's obvious that the algorithm performed better over time.
When testing on the MNIST problem, this was the result achieved by the network.

Correct: 9582
Incorrect: 418
Success Rate:95.82%
Network Architecture: 784 - 800 - 10
Learning Rates: 0.01 - 0.1
Activation Methods: ReLU – Arctan

If the network was randomly guessing - it would have produced a result of ~10% accuracy. My implementation of the neural network produced a success rate of 95.82%. A greater accuracy could have been achieved through more rigorous training - however I'm limited with my testing capacity on my local machine.

A full write up of the network and it's performance can be found [here](https://docs.google.com/document/d/1NMdDzYk8xbH-YqjzGsGxF3E54B3RYd8seJDsoci6-c0/edit?usp=sharing).
