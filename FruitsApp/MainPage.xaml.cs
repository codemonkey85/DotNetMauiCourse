namespace FruitsApp;

public partial class MainPage : ContentPage
{
    public IList<Fruit> Fruits { get; set; } = new List<Fruit>
    {
        new Fruit("Apple", "apple.png", "Apple!"),
        new Fruit("Banana", "banana.png", "Banana!"),
        new Fruit("Coconut", "coconut.png", "Coconut!"),
        new Fruit("Grape", "grape.png", "Grape!"),
        new Fruit("Guava", "guava.png", "Guava!"),
        new Fruit("Kiwi", "kiwi.png", "Kiwi!"),
        new Fruit("Mango", "mango.png", "Mango!"),
        new Fruit("Melon", "melon.png", "Melon!"),
    };

    public MainPage()
    {
        InitializeComponent();
        FruitsList.ItemsSource = Fruits;
    }

    private void FruitsList_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        if (e.CurrentSelection is null || e.CurrentSelection.Count == 0)
        {
            return;
        }
        if (e.CurrentSelection[0] is Fruit fruit)
        {
            Navigation.PushAsync(new FruitDetailPage(fruit));
        }
        if (sender is CollectionView collectionView)
        {
            collectionView.SelectedItem = null;
        }
    }
}
