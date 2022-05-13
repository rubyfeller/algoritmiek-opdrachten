using CircusTrein.Logic.Models;

Console.WriteLine("Hello Circus Train");
CircusTrain();

static void CircusTrain()
{
    Train newTrain = new Train();
    newTrain.AddAnimalsToWagon();

}
