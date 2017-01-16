using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ability : MonoBehaviour 
{
	enum Element{Fire, Earth, Lighting, Ice, Water, Block}

	// Use this for initialization
	void Start () {
		Combine(Element.Fire, Element.Earth);
	}

	public Attack Combine (Element e1, Element e2)
	{
		if((e1 == Element.Fire && e2 == Element.Lighting) || (e1 == Element.Lighting && e2 == Element.Fire))
		{
			return new Plasma();
			Debug.Log("Combo contains fire");
		} 
		else if(e1 == Element.Fire && e2 == Element.Fire)
		{
		return new StrongFire();
		}
		else if((e1 == Element.Fire && e2 == Element.Ice) || (e1 == Element.Ice && e2 == Element.Fire))
		{
		return new IceBurn();
		}
		else if((e1 == Element.Fire && e2 == Element.Earth) || (e1 == Element.Earth && e2 == Element.Fire))
		{
		return new FireBall();
		}
		else if((e1 == Element.Fire && e2 == Element.Water) || (e1 == Element.Water && e2 == Element.Fire))
		{
		return new Steam();
		}
		else if(e1 == Element.Block && e2 == Element.Fire)
		{
		return new FireShield();
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
