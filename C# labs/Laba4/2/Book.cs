namespace test
{
    enum Book_type
    {
        FICTION, FICTION_SOV, FICTION_CLASS, FICTION_TALES, FICTION_HORROR, FICTION_DETECT, FICTION_SCIFI, FICTION_SCIENCE, FICTION_OTHER, PROGRAMMING
    };
    internal class Book
    {
        public string surname;
        public Book_type theme;

        public Book(string surname, Book_type theme)
        {
            this.surname = surname;
            this.theme = theme;
        }

    }
}
