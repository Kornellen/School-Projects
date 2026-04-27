package com.example.myapplication;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.ImageButton;
import android.widget.Toast;

import androidx.activity.EdgeToEdge;
import androidx.appcompat.app.AppCompatActivity;
import androidx.core.graphics.Insets;
import androidx.core.view.ViewCompat;
import androidx.core.view.WindowInsetsCompat;



public class MainActivity extends AppCompatActivity {
    ImageButton[] buttons = new ImageButton[6];
    int[] buttonIds = {R.id.imgBtn1, R.id.imgBtn2, R.id.imgBtn3, R.id.imgBtn4, R.id.imgBtn5, R.id.imgBtn6};
    String[] toastMessages = {"Wybrano Wydarzenia", "Wybrano Aktualności", "Wybrano Wystawy", "Wybrano Edukacja", "Wybrano Zabawy Tematyczne", "Wybrano Kontakt"};
    Class<?>[] activities = {Wydarzenia.class, Aktualnosci.class, Wystawy.class, Edukacja.class, Zabawy.class, Kontakt.class};

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        EdgeToEdge.enable(this);
        setContentView(R.layout.activity_main);
        ViewCompat.setOnApplyWindowInsetsListener(findViewById(R.id.main), (v, insets) -> {
            Insets systemBars = insets.getInsets(WindowInsetsCompat.Type.systemBars());
            v.setPadding(systemBars.left, systemBars.top, systemBars.right, systemBars.bottom);
            return insets;
        });

        for (int i = 0; i < 6; i++)
            new IntentVersion(toastMessages[i], activities[i], i);

        for (int i = 0; i < 6; i++)
            buttons[i] = findViewById(buttonIds[i]);

        int tagVal = 0;
        for (ImageButton button : buttons) {
            button.setTag(tagVal);
            button.setOnClickListener((View v) -> switchIntent(Integer.parseInt(v.getTag().toString())));
            tagVal++;
        }
    }
    private void switchIntent(int tag) {
        Intent intent;
        IntentVersion intentVersion = IntentVersion.getIntentVersion(tag);

        Toast.makeText(this, intentVersion.getToastMessage(), Toast.LENGTH_SHORT).show();
        intent = new Intent(this, intentVersion.getActivity());
        startActivity(intent);
    }
}