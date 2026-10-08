using SchoolDirectoryApp.Models;

namespace SchoolDirectoryApp.Services;

public interface ISchoolService
{
    Task<List<School>> GetSchoolsAsync();
}