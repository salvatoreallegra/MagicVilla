﻿using MagicVilla_VillaAPI.Model.DTO;

namespace MagicVilla_VillaAPI.Data
{
    public static class VillaStore
    {

            public static List<VillaDTO> villaList = new List<VillaDTO>
            {
                new VillaDTO { Id=1,Name="Pool View",Sqft=400,Occupancy=4 },
                new VillaDTO { Id=2,Name="Beach View",Sqft=600,Occupancy=5}
            };
        
    }
}
