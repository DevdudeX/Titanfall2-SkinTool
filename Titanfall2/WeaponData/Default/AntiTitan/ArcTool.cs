using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Titanfall2_SkinTool.Titanfall2.WeaponData.Default.AntiTitan
{
    class ArcTool
    {
        public struct ReallyData
        {
            public string name;
            public long seek;
            public int length;
            public int seeklength;
        }

        public ReallyData[] ArcTool_col;
        public ReallyData[] ArcTool_ilm;

        public ArcTool()
        {
            int i = 1;

            ArcTool_col = new ReallyData[3];
            ArcTool_ilm = new ReallyData[3];

            //2=2048x2048, 1=1024x1024, 0=512x512

            ArcTool_col[0].name = "col";
            ArcTool_col[0].seek = 9288749056;
            ArcTool_col[0].length = 131072;
            ArcTool_col[0].seeklength = 128;
            while (i <= 2)
            {
                ArcTool_col[i].name = "col";
                ArcTool_col[i].seek = ArcTool_col[i - 1].seek + ArcTool_col[i - 1].length;
                ArcTool_col[i].length = ArcTool_col[i - 1].length * 4;
                ArcTool_col[i].seeklength = 128;
                i++;
            }
            i = 1;

            ArcTool_ilm[0].name = "ilm";
            ArcTool_ilm[0].seek = 9302577152;
            ArcTool_ilm[0].length = 131072;
            ArcTool_ilm[0].seeklength = 128;
            while (i <= 2)
            {
                ArcTool_ilm[i].name = "ilm";
                ArcTool_ilm[i].seek = ArcTool_ilm[i - 1].seek + ArcTool_ilm[i - 1].length;
                ArcTool_ilm[i].length = ArcTool_ilm[i - 1].length * 4;
                ArcTool_ilm[i].seeklength = 128;
                i++;
            }
            i = 1;
        }
    }
}
