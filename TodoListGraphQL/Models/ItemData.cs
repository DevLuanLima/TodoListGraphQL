namespace TodoListGraphQL.Models
{
     public class ItemData
    {
        public int Id { get; set; }
        public string Tittle { get; set; }
        public string Description { get; set; }
        public bool IsDone { get; set; }
        public int ListId { get; set; }
        public virtual ItemList ItemList {get;set;}

    }
}