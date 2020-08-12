using System;
using System.Collections.Generic;

[Serializable]
public class Encounter
{
    public string EncounterTitle { get; set; }
    public Outcome OnEncounterOutcome { get; set; }
    public IDictionary<string, Outcome> Actions { get; set; }
}

[Serializable]
public class Outcome
{
    private readonly Action<VanContext> action;

    public Outcome(Action<VanContext> action)
    {
        this.action = action;
    }

    public void Execute(VanContext vanContext)
    {
        action(vanContext);
    }
}

//public class Stuff
//{
//    public void Thing()
//    {
//        var encounter = new Encounter
//        {
//            EncounterTitle = "the encounter",
//            OnEncounterOutcome = new Outcome(vanContext => { /*do stuff */}),
//            Actions =
//            {
//                { "", new Outcome(vanContext => { }) }
//            }
//        };
//    }
//}