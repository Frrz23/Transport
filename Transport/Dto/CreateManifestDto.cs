namespace Transport.Dto
{
    public class CreateManifestDto
    {
        public int SeriesId { get; set; }
        public string MfNo { get; set; }
        public DateTime Date { get; set; }
        public string? NepaliDate { get; set; }

        public int FromBranchId { get; set; }
        public int TruckId { get; set; }
        public string? Remarks { get; set; }

        public List<CreateManifestItemDto> Items { get; set; } = new();
    }

}
