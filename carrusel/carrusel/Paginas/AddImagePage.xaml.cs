using System.Collections.ObjectModel;

namespace carrusel.Paginas;

public partial class AddImagePage : ContentPage
{
    private ObservableCollection<ImageItem> _images;

    public AddImagePage(ObservableCollection<ImageItem> images)
    {
        InitializeComponent();
        _images = images;
        UploadDatePicker.Date = DateTime.Now;
    }

    private async void OnAddImage(object sender, EventArgs e)
    {
        var newImage = new ImageItem
        {
            ImagePath = ImagePathEntry.Text, // miro la ruta de la imagen
            Description = DescriptionEntry.Text, // descripcion
            UploadDate = UploadDatePicker.Date // fecha 
        };

        _images.Add(newImage); // añado la imagen a la lista
        await Navigation.PopAsync();
    }
}