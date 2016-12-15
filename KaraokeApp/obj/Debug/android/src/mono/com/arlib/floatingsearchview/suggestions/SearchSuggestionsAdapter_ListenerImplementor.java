package mono.com.arlib.floatingsearchview.suggestions;


public class SearchSuggestionsAdapter_ListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.arlib.floatingsearchview.suggestions.SearchSuggestionsAdapter.Listener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onItemSelected:(Lcom/arlib/floatingsearchview/suggestions/model/SearchSuggestion;)V:GetOnItemSelected_Lcom_arlib_floatingsearchview_suggestions_model_SearchSuggestion_Handler:FloatingSearchViews.Suggestions.SearchSuggestionsAdapter/IListenerInvoker, FloatingSearchView\n" +
			"n_onMoveItemToSearchClicked:(Lcom/arlib/floatingsearchview/suggestions/model/SearchSuggestion;)V:GetOnMoveItemToSearchClicked_Lcom_arlib_floatingsearchview_suggestions_model_SearchSuggestion_Handler:FloatingSearchViews.Suggestions.SearchSuggestionsAdapter/IListenerInvoker, FloatingSearchView\n" +
			"";
		mono.android.Runtime.register ("FloatingSearchViews.Suggestions.SearchSuggestionsAdapter+IListenerImplementor, FloatingSearchView, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", SearchSuggestionsAdapter_ListenerImplementor.class, __md_methods);
	}


	public SearchSuggestionsAdapter_ListenerImplementor () throws java.lang.Throwable
	{
		super ();
		if (getClass () == SearchSuggestionsAdapter_ListenerImplementor.class)
			mono.android.TypeManager.Activate ("FloatingSearchViews.Suggestions.SearchSuggestionsAdapter+IListenerImplementor, FloatingSearchView, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onItemSelected (com.arlib.floatingsearchview.suggestions.model.SearchSuggestion p0)
	{
		n_onItemSelected (p0);
	}

	private native void n_onItemSelected (com.arlib.floatingsearchview.suggestions.model.SearchSuggestion p0);


	public void onMoveItemToSearchClicked (com.arlib.floatingsearchview.suggestions.model.SearchSuggestion p0)
	{
		n_onMoveItemToSearchClicked (p0);
	}

	private native void n_onMoveItemToSearchClicked (com.arlib.floatingsearchview.suggestions.model.SearchSuggestion p0);

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
