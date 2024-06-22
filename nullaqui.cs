// Instantiate an object to the right of the current object
thePosition = transform.TransformPoint(Vector3.right * 2);
Instantiate(someObject, thePosition, someObject.transform.rotation);
