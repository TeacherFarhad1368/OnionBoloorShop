namespace Utility.Domain
{
    public class BaseEntityDate<Tkey> : BaseEntity<Tkey>
    {
        public DateTime CreationDate { get; set; }
        public BaseentityDate()
        {
            CreationDate = DateTime.Now;
        }
    }
}
