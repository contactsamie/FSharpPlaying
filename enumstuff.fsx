open System

type emotion=
    | Joy =0
    | fear = 1
    | anger = 2

let enumStuff (my_feeling:emotion)=
  match  my_feeling with 
                    | joy -> printf "I'm joyfull" 
                    | fear -> printf "I'm fearfull"  


enumStuff(emotion.anger)

enumStuff(emotion.fear)