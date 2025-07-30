namespace Transport.Models
{
    public class SubBranch
    {
        public int SubBranchId { get; set; }
        public int BranchId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        public Branch Branch { get; set; }
    }
}