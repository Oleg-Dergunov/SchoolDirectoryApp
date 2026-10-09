using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;

namespace SchoolDirectoryApp.Services;

public class FavouritesService : IFavouritesService
{
    private const string StorageKey = "favourite-school-ids";

    private readonly ProtectedLocalStorage _storage;
    private readonly HashSet<int> _ids = new();
    private bool _loaded;

    public FavouritesService(ProtectedLocalStorage storage) => _storage = storage;

    public int Count => _ids.Count;

    public bool IsFavourite(int schoolId) => _ids.Contains(schoolId);

    public async Task LoadAsync()
    {
        if (_loaded) return;

        try
        {
            var result = await _storage.GetAsync<int[]>(StorageKey);
            if (result.Success && result.Value is not null)
            {
                foreach (var id in result.Value)
                {
                    _ids.Add(id);
                }
            }
        }
        catch
        {
        }

        _loaded = true;
    }

    public async Task ToggleAsync(int schoolId)
    {
        if (!_ids.Remove(schoolId))
        {
            _ids.Add(schoolId);
        }

        await _storage.SetAsync(StorageKey, _ids.ToArray());
    }
}