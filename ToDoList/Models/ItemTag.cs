namespace ToDoList.Models
{
    public class ItemTag
    {   //auto implemented properties
        public int ItemTagId { get; set; }
        public int ItemId { get; set; }
        public Item Item { get; set; }
        public int TagId { get; set; }
        public Tag Tag { get; set; }
    }
}