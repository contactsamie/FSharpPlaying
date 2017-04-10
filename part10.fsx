type Details={Name:string;Description:string}
type Item = {Details:Details}
type Exit= // descr union allows us to define states and the varios data associated with it
    |PassableExit of Details * destination:Room// has details. desination is just a label
    |LockedExit of Details * key:Item * next: Exit
    |NoExit of Details option
and Exits={North:Exit;South:Exit;East:Exit;West:Exit}
and Room={Details:Details;Exit:Exits;Items:Item seq} // just saying you want to have a Items which is a list of item

let firstRoom={
        Details={Name="sam room";Description="my first room"};
        Exit= {North=NoExit(None); South=NoExit(None); East=NoExit(None); West=NoExit(None)};
        Items=[]
    }


