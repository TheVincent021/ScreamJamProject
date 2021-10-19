using UnityEngine;

public class CameraFollow : MonoBehaviour 
{
	#region Fields
	[SerializeField] Transform target;
	[SerializeField] [Range(0f, 1f)] float followSmoothness = 0.2f;

	Vector3 offset;

	Transform m_Transform;
	#endregion

	#region Callbacks
	void Awake ()
	{
		MakeReferences();
	}

	void Start () 
	{
		CalculateOffset();
	}

	void FixedUpdate () 
	{
		UpdatePosition();
	}
	#endregion

	void MakeReferences () {
		m_Transform = transform;
	}

	void CalculateOffset () {
		offset = m_Transform.position - target.position;
	}

	void UpdatePosition () {
		m_Transform.position = Vector3.Lerp
			(m_Transform.position, target.position + offset, 1 - followSmoothness);
	}
}
