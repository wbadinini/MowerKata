using System.Collections;
using System.Collections.Generic;
using MowerKata.Entities;
using MowerKata.Exceptions;

namespace MowerKata.Services
{
    public class OrderQueryProcess : IEnumerable
    {
        public List<ForwardingEnum> ForwardingQuery { get; set; }

        public OrderQueryProcess()
        {
            ForwardingQuery = new List<ForwardingEnum>();
        }

        public static OrderQueryProcess Parser(string query)
        {
            var orderQueryProcess = new OrderQueryProcess();
            foreach (var queryInstruction in query)
            {
                switch (queryInstruction)
                {
                    case 'A':
                        orderQueryProcess.ForwardingQuery.Add(ForwardingEnum.Forward);
                        break;
                    case 'D':
                        orderQueryProcess.ForwardingQuery.Add(ForwardingEnum.Right);
                        break;
                    case 'G':
                        orderQueryProcess.ForwardingQuery.Add(ForwardingEnum.Left);
                        break;
                    default:
                        throw new InvalidCommandFormatException();
                }
            }

            return orderQueryProcess;
        }

        public IEnumerator GetEnumerator()
        {
            return ForwardingQuery.GetEnumerator();
        }
    }
}