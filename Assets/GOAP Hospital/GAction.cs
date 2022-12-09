using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public abstract class GAction : MonoBehaviour {

    // Name of the action
    public string actionName = "Action";
    // Cost of the action
    public float cost = 1.0f;
    // Target where the action is going to take place
    public GameObject target;
    // Store the tag
    public string targetTag;
    // Duration the action should take
    public float duration = 0.0f;
    // An array of WorldStates of preconditions
    public WorldState[] preConditions;
    // An array of WorldStates of afterEffects
    public WorldState[] afterEffects;
    // The NavMEshAgent attached to the agent
    public NavMeshAgent agent;
    // Dictionary of preconditions
    public Dictionary<string, int> preconditions;
    // Dictionary of effects
    public Dictionary<string, int> effects;
    // State of the agent
    public WorldStates agentBeliefs;
    // Are we currently performing an action?
    public bool running = false;

    // Constructor
    public GAction() {

        // Set up the preconditions and effects
        preconditions = new Dictionary<string, int>();
        effects = new Dictionary<string, int>();
    }

    private void Awake() {

        // Get hold of the agents NavMeshAgent
        agent = this.gameObject.GetComponent<NavMeshAgent>();

        // Check validity of preConditions
        if (preConditions != null) {

            foreach (WorldState w in preConditions) {

                // Add each item to our Dictionary
                preconditions.Add(w.key, w.value);
            }
        }

        // Check validity of afterEffects
        if (afterEffects != null) {

            foreach (WorldState w in afterEffects) {

                // Add each item to our Dictionary
                effects.Add(w.key, w.value);
            }
        }
    }

    public bool IsAchievable() {

        return true;
    }

    public bool IsAhievableGiven(Dictionary<string, int> conditions) {

        foreach (KeyValuePair<string, int> p in preconditions) {

            if (!conditions.ContainsKey(p.Key)) {

                return false;
            }
        }
        return true;
    }

    public abstract bool PrePerform();
    public abstract bool PostPerform();
}
