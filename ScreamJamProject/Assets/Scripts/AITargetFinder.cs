using Pathfinding;
using UnityEngine;

[RequireComponent(typeof(AIDestinationSetter))]
public class AITargetFinder : MonoBehaviour
{
    #region Fields
    [SerializeField] Transform[] patrolSpots;
    [SerializeField] float minimumDistance = 0.1f;
    [SerializeField] bool isPlayerFound = false;
    [SerializeField] float awarenessDistance = 10f;
    int currentIndex = 0;

    Transform target;
    Transform player;
    AIDestinationSetter m_destination;
    SpriteRenderer m_graphics;
    #endregion

    #region Callbacks
    void Awake () {
        MakeReferences();
    }

    void Start () {
        SetInitialTarget();
    }

    void Update () {
        UpdateAITarget();
        FlipGraphics();
        SearchForPlayer();
        SetTarget();
    }

    void OnTriggerEnter2D (Collider2D col) {
        if (col.CompareTag("Player")) GetComponentInChildren<Animator>().SetTrigger("Attack");
    }
    #endregion

    void MakeReferences () {
        player = GameObject.FindWithTag("Player").transform;
        m_destination = GetComponent<AIDestinationSetter>();
        m_graphics = GetComponentInChildren<SpriteRenderer>();
    }

    void SetInitialTarget () {
        target = patrolSpots[currentIndex];
    }

    void UpdateAITarget () {
        m_destination.target = target;
    }

    void FlipGraphics () {
        if (target.position.x > transform.position.x) {
            m_graphics.flipX = true;
        } else {
            m_graphics.flipX = false;
        }
    }

    void SearchForPlayer () {
        isPlayerFound = Vector3.Distance(player.position, transform.position) <= awarenessDistance ? true : false;

    }

    void SetTarget () {
        if (isPlayerFound) {
            ChasePlayer();
        } else {
            Patrol();
        }
    }

    void Patrol() {
        if (Vector3.Distance(target.position, transform.position) <= minimumDistance) {
            if (currentIndex < patrolSpots.Length - 1) currentIndex++; else currentIndex = 0;
            target = patrolSpots[currentIndex];
        }
    }

    void ChasePlayer () {
        target = player;
    }
}
