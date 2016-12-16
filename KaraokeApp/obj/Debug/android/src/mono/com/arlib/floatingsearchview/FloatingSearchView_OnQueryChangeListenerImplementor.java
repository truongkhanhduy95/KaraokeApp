package mono.com.arlib.floatingsearchview;


public class FloatingSearchView_OnQueryChangeListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.arlib.floatingsearchview.FloatingSearchView.OnQueryChangeListener
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_onSearchTextChanged:(Ljava/lang/String;Ljava/lang/String;)V:GetOnSearchTextChanged_Ljava_lang_String_Ljava_lang_String_Handler:FloatingSearchViews.FloatingSearchView/IOnQueryChangeListenerInvoker, FloatingSearchView\n" +
			"";
		mono.android.Runtime.register ("FloatingSearchViews.FloatingSearchView+IOnQueryChangeListenerImplementor, FloatingSearchView, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", FloatingSearchView_OnQueryChangeListenerImplementor.class, __md_methods);
	}


	public FloatingSearchView_OnQueryChangeListenerImplementor () throws java.lang.Throwable
	{
		super ();
		if (getClass () == FloatingSearchView_OnQueryChangeListenerImplementor.class)
			mono.android.TypeManager.Activate ("FloatingSearchViews.FloatingSearchView+IOnQueryChangeListenerImplementor, FloatingSearchView, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onSearchTextChanged (java.lang.String p0, java.lang.String p1)
	{
		n_onSearchTextChanged (p0, p1);
	}

	private native void n_onSearchTextChanged (java.lang.String p0, java.lang.String p1);

	java.util.ArrayList refList;
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
