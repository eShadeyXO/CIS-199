//Program 4
//CIS 199-02
//GRADING ID: B5992
//DUE: Tuesday, 4/24/2017
//This program collects information about a package and then tells you the cost to ship the package from the
//specified origin zip to the specified destination zip in a list box. It also contains features such as the
//details button that tells you all the details of the package as well as the send to uofl and send from uofl
//buttons that change the origin or dest zip and recalculate the price.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_4
{
    public class GroundPackage
    {
        private int _originZip; //backing field for origin zip.
        private int _destZip; //backing field for destination zip.
        private double _length; //backing field for length.
        private double _width;//backsing field for width.
        private double _height;//backing field for height.
        private double _weight;//backing field for weight.

        //Precondition: Length, width, height,weight all > 0. origin zip and destination zip
        // are > 00000 and <99999.
        //Postcondition: A package has been constructed with the specified properties.
        public GroundPackage(int oZip, int dZip, double length, double width,
            double height, double weight)
        {
            OriginZip = oZip;
            DestinationZip = dZip;
            Length = length;
            Width = width;
            Height = height;
            Weight = weight; 
        }

        public int OriginZip
        {
            //Precondition:None
            //Postcondition: origin zip has been returned.
            get
            {
                return _originZip;
            }
            //Precondition: origin zip is > 00000 and <99999
            //Postcondition: origin zip has been set to specified value.
            set
            {
                if (value > 00000 && value < 99999)
                {
                    _originZip = value;
                }
                else
                {
                    _originZip = 90210;
                }
            }
        }

        public int DestinationZip
        {
            //Precondition: None
            //Postcondition: Returns destination zip.
            get
            {
                return _destZip;
            }
            //Precondition: Value > 00000 and <99999
            //Postcondition: Sets dest zip to specified value.
            set
            {
                if(value > 00000 && value < 99999)
                {
                    _destZip = value;
                }
                else
                {
                    _destZip = 90210;
                }
            }

        }

        public double Length
        {
            //Precondition: None
            //Postcondition: Returns the length.
            get
            {
                return _length;
            }
            //Precondition: value > 0
            //Postcondition: Length has been set to the specified number.
            set
            {
                if(value > 0)
                {
                    _length = value;
                }
                else
                {
                    _length = 1.0;
                }
            }
        }

        public double Width
        {
            //Precondition: None
            //Postcondition: Returns width
            get
            {
                return _width;
            }
            //Precondition: value>0
            //Postcondition: Width has been set to the specified number.
            set
            {
                if (value > 0)
                {
                    _width = value;
                }
                else
                {
                    _width = 1.0;
                }
            }
        }

        public double Height
        {
            //Precondition:None
            //Postcondition: Returns the height.
            get
            {
                return _height;
            }
            //Precondition: value>0
            //Postcondition: Height has been set to the specified number.
            set
            {
                if (value > 0)
                {
                    _height = value;
                }
                else
                {
                    _height = 1.0;
                }
            }
        }

        public double Weight
        {
            //Precondition: None
            //Postcondition: Returns the weight
            get
            {
                return _weight;
            }
            //Precondition: value >0
            //Postcondition: Weight has been set to the specified number.
            set
            {
                if (value > 0)
                {
                    _weight = value;
                }
                else
                {
                    _weight = 1.0;
                }
            }
        }

        public int ZoneDistance
        {
            //Precondition: None
            //Postcondition: Returns the zone distance.
            get
            {
                int zoneDist; //To hold zone distance.
                zoneDist = Math.Abs((_originZip / 10000) - (_destZip / 10000));
                return zoneDist;
            }
        }
        //Precondition:None
        //Postcondition: Returns the price it costs to ship the package.
        public double CalcCost()
        {
            return .20 * (Length + Width + Height) + .5 * (ZoneDistance + 1) * (Weight);
        }
        //Precondition: None
        //Postcondition: Returns a string representation of the package details.
        public override string ToString()
        {
            return "Origin Zip: " + OriginZip + System.Environment.NewLine
                +"Destination Zip: "+DestinationZip+System.Environment.NewLine
                +"Length: "+Length+System.Environment.NewLine
                +"Width: "+Width+"\n"+"Height: "+Height+System.Environment.NewLine
                +"Weight: " + Weight + System.Environment.NewLine;

        }
    }
}
