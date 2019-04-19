namespace FSharpEventBug

type IFSharpInterface = 
    [<CLIEvent>]
    abstract TheEvent: IEvent<exn>