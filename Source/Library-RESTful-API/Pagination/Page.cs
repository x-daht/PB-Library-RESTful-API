using System.Globalization;

namespace Pagination;

#pragma warning disable

/// <summary>
/// Response page [Endpoint - HTTP GET method]
/// </summary>
public sealed class Page<TEntity> where TEntity : class
{
    public string DateOfRequest { get; set; }

    public int TotalPages { get; init; }
    
    public int TotalRecords { get; init; }

    public int PageNumber { get; init; }
    
    public int PageSize { get; init; }

    public string NextPage { get; init; }

    public string PreviousPage { get; init; }

    public string FirstPage { get; init; }

    public string LastPage { get; init; }

    public IEnumerable<TEntity> Data { get; init; }

    public Page(int totalPages, int totalRecords, int pageNumber, int pageSize, string nextPage, string previousPage, string firstPage, string lastPage, IEnumerable<TEntity> data)
    {
        DateOfRequest = DateTime.Now.ToString("dd/MM/yyyy - mm:hh:ss tt", CultureInfo.CurrentCulture);
        TotalPages = totalPages;
        TotalRecords = totalRecords;
        PageNumber = pageNumber;
        PageSize = pageSize;
        NextPage = nextPage;
        PreviousPage = previousPage;
        FirstPage = firstPage;
        LastPage = lastPage;
        Data = data;
    }
}