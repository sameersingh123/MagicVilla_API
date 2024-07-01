using MagicVilla_VillaAPI.Models.Dto;

namespace MagicVilla_VillaAPI.Data
{
    public static class VillaStore
    {
        public static List<VillaDto> VillaList = new List<VillaDto>
        {
            new VillaDto{Id=1, Name="Pool View", Sqft=300, Occupancy=50},
            new VillaDto{Id=2, Name="Beach View", Sqft=400, Occupancy=80}

        };

    }
}
