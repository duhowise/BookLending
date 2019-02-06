namespace BookLending.Books
{
    public class UpdateBookInput
    {
        public int Id { get; set; }
        public string DisplayName { get; set; }
        public int? TotalPageNumber { get; set; }
        public int AuthorId { get; set; }
        public int CategoryId { get; set; }
    }
}