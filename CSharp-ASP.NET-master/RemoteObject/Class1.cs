using System;

namespace nameSpaceRemote
{
    public class RemoteObject : MarshalByRefObject
    {
        ///constructor
        public RemoteObject()
        {
            Console.WriteLine("Remote object activated");
        }
        public void Affichage()
        {
            Console.WriteLine("Test");
        }
    }
}
