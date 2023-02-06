// PascalCasing for C#
namespace Finger
{
    // record in my code when i need something that aggregates two pieces of data. this ties the string of "Status" with the time of "DateTimeOffset"
    public record StatusMessage(Guid Id, string Status, DateTimeOffset When);

}
