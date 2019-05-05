using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Mower.Tests
{
    [TestFixture]
    public class MowerTest
    {
        // tendeuse a initialemet les informations coords, direction
        // 
        [Test]
        public void Test()
        {
            var mower = new Mower(new Coords(0, 0), 'N');
            var controller = new Controller(new Coords(5, 5));

            var finalPosition = controller.Mow(mower, "A");

            Assert.AreEqual(new Coords(0, 1), finalPosition);
        }
    }

    public class Controller
    {
        public Controller(Coords coords)
        {
            throw new NotImplementedException();
        }

        public object Mow(Mower mower, string s)
        {
            throw new NotImplementedException();
        }
    }

    public class Mower
    {
        private Coords coords;
        private char v;

        public Mower(Coords coords, char v)
        {
            this.coords = coords;
            this.v = v;
        }
    }

    public class Coords
    {
        public Coords(int i, int i1)
        {
            throw new NotImplementedException();
        }
    }
}
