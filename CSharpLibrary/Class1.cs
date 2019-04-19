using System;
using FSharpEventBug;
using Microsoft.FSharp.Control;

namespace CSharpLibrary
{
    public class Class1 : IFSharpInterface
    {
        // This is what Rider generates automatically. No errors in editor, but it does not compile.
        public void TheEvent(FSharpHandler<Exception> missing_name)
        {
        }
    }

    // This class compiles, but Rider shows errors
    public class Class2 : IFSharpInterface
    {
        event FSharpHandler<Exception> IFSharpInterface.TheEvent
        {
            add { }
            remove { }
        }
    }
}