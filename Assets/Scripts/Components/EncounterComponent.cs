using UnityEngine;

public class EncounterComponent : MonoBehaviour
{
    [SerializeField] private VanComponent Van;

    void Start()
    {
        // This is what we need to make work next. Resources should be accessible through van context.
        var encounter1 = new Encounter
        {
            EncounterTitle = "Bandits! OMGahz!",
            OnEncounterOutcome = new Outcome(vanContext =>
            {
                // lose 5 supplies
            }),
            Actions =
            {
                { "Buy back supplies", new Outcome(vanContext => {
                    // gain 5 supply
                    // lose 10 money
                }) },
                { "Run!", new Outcome(vanContext => {
                    // lose 2 gas
                }) },
            }
        };
    }

    void Update()
    {
        
    }
}
