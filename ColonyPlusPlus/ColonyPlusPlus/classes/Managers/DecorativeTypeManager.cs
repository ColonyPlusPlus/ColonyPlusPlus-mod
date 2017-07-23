using ColonyPlusPlus.classes.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ColonyPlusPlus.classes;

namespace ColonyPlusPlus.classes.Managers
{
    class DecorativeTypeManager
    {
        public enum TypeOption
        {
            Block,
            Slope,
            SlopeCorner,
            Curve,
            CurveCorner,
            CurveRotated

        };

        private string baseName;


        public DecorativeTypeManager(string basename, string basematerial, string craftingrequireditem, string craftingtype, TypeOption[] typeoptions)
        {
            this.baseName = basename;
           
            // loop through typeoptions
            foreach(TypeOption type in typeoptions)
            {
                switch(type)
                {
                    case TypeOption.Block:

                        DecorativeTypeBlock d = new DecorativeTypeBlock(basename, basematerial, craftingtype);

                        break;
                    case TypeOption.Slope:

                        DecorativeTypeBase dslope = new DecorativeTypeBase(basename, "slope", basematerial, craftingrequireditem, craftingtype);
                        DecorativeTypeXMinus dslopexm = new DecorativeTypeXMinus(basename, "slope", basematerial);
                        DecorativeTypeXPlus dslopexp = new DecorativeTypeXPlus(basename, "slope", basematerial);
                        DecorativeTypeZMinus dslopezm = new DecorativeTypeZMinus(basename, "slope", basematerial);
                        DecorativeTypeZPlus dslopezp = new DecorativeTypeZPlus(basename, "slope", basematerial);

                        break;

                    case TypeOption.SlopeCorner:

                        DecorativeTypeBase dslopecorner = new DecorativeTypeBase(basename, "slopecorner", basematerial, craftingrequireditem, craftingtype);
                        DecorativeTypeXMinus dslopecornerxm = new DecorativeTypeXMinus(basename, "slopecorner", basematerial);
                        DecorativeTypeXPlus dslopecornerxp = new DecorativeTypeXPlus(basename, "slopecorner", basematerial);
                        DecorativeTypeZMinus dslopecornerzm = new DecorativeTypeZMinus(basename, "slopecorner", basematerial);
                        DecorativeTypeZPlus dslopecornerzp = new DecorativeTypeZPlus(basename, "slopecorner", basematerial);

                        break;
                    case TypeOption.Curve:

                        DecorativeTypeBase dcurve = new DecorativeTypeBase(basename, "curve", basematerial, craftingrequireditem, craftingtype);
                        DecorativeTypeXMinus dcurvexm = new DecorativeTypeXMinus(basename, "curve", basematerial);
                        DecorativeTypeXPlus dcurvexp = new DecorativeTypeXPlus(basename, "curve", basematerial);
                        DecorativeTypeZMinus dcurvezm = new DecorativeTypeZMinus(basename, "curve", basematerial);
                        DecorativeTypeZPlus dcurvezp = new DecorativeTypeZPlus(basename, "curve", basematerial);

                        break;
                    case TypeOption.CurveRotated:

                        DecorativeTypeBase dcurverotated = new DecorativeTypeBase(basename, "curverotated", basematerial, craftingrequireditem, craftingtype);
                        DecorativeTypeXMinus dcurverotatedxm = new DecorativeTypeXMinus(basename, "curverotated", basematerial);
                        DecorativeTypeXPlus dcurverotatedxp = new DecorativeTypeXPlus(basename, "curverotated", basematerial);
                        DecorativeTypeZMinus dcurverotatedzm = new DecorativeTypeZMinus(basename, "curverotated", basematerial);
                        DecorativeTypeZPlus dcurverotatedzp = new DecorativeTypeZPlus(basename, "curverotated", basematerial);

                        break;

                    case TypeOption.CurveCorner:

                        DecorativeTypeBase dcurvecorner = new DecorativeTypeBase(basename, "curvecorner", basematerial, craftingrequireditem, craftingtype);
                        DecorativeTypeXMinus dcurvecornerxm = new DecorativeTypeXMinus(basename, "curvecorner", basematerial);
                        DecorativeTypeXPlus dcurvecornerxp = new DecorativeTypeXPlus(basename, "curvecorner", basematerial);
                        DecorativeTypeZMinus dcurvecornerzm = new DecorativeTypeZMinus(basename, "curvecorner", basematerial);
                        DecorativeTypeZPlus dcurvecornerzp = new DecorativeTypeZPlus(basename, "curvecorner", basematerial);

                        break;

                }
            }
        }


    }
}