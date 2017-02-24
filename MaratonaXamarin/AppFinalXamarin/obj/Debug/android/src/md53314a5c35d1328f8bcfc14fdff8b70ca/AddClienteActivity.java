package md53314a5c35d1328f8bcfc14fdff8b70ca;


public class AddClienteActivity
	extends android.support.v7.app.AppCompatActivity
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreate:(Landroid/os/Bundle;)V:GetOnCreate_Landroid_os_Bundle_Handler\n" +
			"";
		mono.android.Runtime.register ("AppFinalXamarin.AddClienteActivity, AppFinalXamarin, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", AddClienteActivity.class, __md_methods);
	}


	public AddClienteActivity () throws java.lang.Throwable
	{
		super ();
		if (getClass () == AddClienteActivity.class)
			mono.android.TypeManager.Activate ("AppFinalXamarin.AddClienteActivity, AppFinalXamarin, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onCreate (android.os.Bundle p0)
	{
		n_onCreate (p0);
	}

	private native void n_onCreate (android.os.Bundle p0);

	private java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
