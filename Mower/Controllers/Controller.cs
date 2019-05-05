using MowerKata.Entities;
using MowerKata.Services;

namespace MowerKata.Controllers
{
    public class Controller
    {
        private readonly Coords _areaCoords;

        public Controller(Coords areaCoords)
        {
            _areaCoords = areaCoords;
        }

        public void Mow(MowerKata.Entities.Mower mower, string commands)
        {
            var queryOrders = OrderQueryProcess.Parser(commands);

            foreach (var order in queryOrders)
            {
                switch (order)
                {
                    case ForwardingEnum.Forward:
                    {
                        var previousCoords = new Coords(mower.CurrentCoords);

                        mower.Forward();

                        if (mower.CurrentCoords.X > _areaCoords.X || mower.CurrentCoords.Y > _areaCoords.Y)
                        {
                            mower.CurrentCoords = previousCoords;
                        }

                        break;
                    }
                    case ForwardingEnum.Right:
                        mower.ToRight();
                        break;
                    case ForwardingEnum.Left:
                        mower.ToLeft();
                        break;
                }
            }
        }
    }
}