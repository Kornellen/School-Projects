package com.example.myapplication;

import java.util.HashMap;

public class IntentVersion {
    private static final HashMap<Integer, IntentVersion> intentVersions = new HashMap<>();
    private String toastMessage;
    private Class<?> activity;

    private void setToastMessage(String toastMessage) {
        this.toastMessage = toastMessage;
    }
    private void setActivity(Class<?> activity) {
        this.activity = activity;
    }

    public String getToastMessage() {
        return this.toastMessage;
    }
    public Class<?> getActivity() {
        return activity;
    }

    public static IntentVersion getIntentVersion(int tag) {
        return intentVersions.get(tag);
    }

    IntentVersion(String toastMessage, Class<?> activity, int tag) {
        setToastMessage(toastMessage);
        setActivity(activity);

        IntentVersion.intentVersions.put(tag, this);
    }
}
