namespace FruitsApp;

public partial class FruitDetailPage : ContentPage
{
    public FruitDetailPage(Fruit fruit)
    {
        InitializeComponent();
        (LblFruitName.Text, ImgFruit.Source, LblFruitDescription.Text) = fruit;
    }
}
