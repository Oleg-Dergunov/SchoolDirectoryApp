namespace SchoolDirectoryApp.Services;

public interface IFavouritesService
{
    int Count { get; }
    bool IsFavourite(int schoolId);
    Task LoadAsync();
    Task ToggleAsync(int schoolId);
}