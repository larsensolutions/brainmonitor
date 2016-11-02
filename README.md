# brainmonitor
Program developed as part of my master thesis at NTNU, spring 2011.
Include dlls in DLLs folder in project as referance when cloned!

Thesis is located in Thesis folder.
# abstract from thesis

Electroencephalography (EEG) equipment are becoming more available on the
public market, which enables more diverse research in a currently narrow field.
The Brain-Computer Interface (BCI) community recognize the need for systems
that makes BCI more user-friendly, real-time, manageable and suited for people
that are not forced to use them, like clinical patients, and those who are disabled.
Thus, this project is an effort to seek such improvements, having a newly available
market product to experiment with: a single channel brain wave reader. However,
it is important to stress that this shift in BCI, from patients to healthy and ordinary
users, should ultimately be beneficial for those who really need it, indeed.
The main focus have been building a system which enables usage of the available
EEG device, and making a prototype that incorporates all parts of a functioning
BCI system. These parts are 1) acquiring the EEG signal 2) process and classify the
EEG signal and 3) use the signal classification to control a feature in a game. The
solution method in the project uses the NeuroSky mindset for part 1, the Fourier
transform and an artificial neural network for classifying brain wave patterns in
part 2, and a game of Snake uses the classification results to control the character
in part 3.

This report outlines the step-by-step implementation and testing for this system,
and the result is a functional prototype that can use user EEG to control the snake
in the game with over 90% accuracy. Two mental tasks have been used to separate
between turning the snake left or right, baseline (thinking nothing in particular)
and mental counting. The solution differentiates from other appliances of the NeuroSky
mindset that it does not require any pre-training for the user, and it is only
partially real-time.

#contact
http://larsensolutions.no/
