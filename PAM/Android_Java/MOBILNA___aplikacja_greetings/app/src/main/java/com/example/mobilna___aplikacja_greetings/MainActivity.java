package com.example.mobilna___aplikacja_greetings;

import android.os.Bundle;
import android.widget.Button;
import android.widget.SeekBar;
import android.widget.TextView;

import androidx.activity.EdgeToEdge;
import androidx.appcompat.app.AppCompatActivity;
import androidx.core.graphics.Insets;
import androidx.core.view.ViewCompat;
import androidx.core.view.WindowInsetsCompat;

public class MainActivity extends AppCompatActivity {
    private final String[] greetings = {"Dzień dobry", "Good morning", "Buenos dias"};
    private int counter = 0;
    private TextView greetingsTView;
    private TextView sizeTView;
    private SeekBar sizeSeekBar;
    private Button nextBtn;

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

        greetingsTView = findViewById(R.id.greetingTView);
        sizeTView = findViewById(R.id.sizeTView);

        sizeSeekBar = findViewById(R.id.sizeSeekBar);

        nextBtn = findViewById(R.id.nextBtn);

        nextBtn.setOnClickListener(v -> {
            counter++;
            if (counter >= greetings.length) counter = 0;

            greetingsTView.setText(greetings[counter]);
        });

        sizeSeekBar.setOnSeekBarChangeListener(new SeekBar.OnSeekBarChangeListener() {
            @Override
            public void onProgressChanged(SeekBar seekBar, int i, boolean b) {
                sizeTView.setText("Rozmiar: " + i);

                greetingsTView.setTextSize(i);
            }

            @Override
            public void onStartTrackingTouch(SeekBar seekBar) {

            }

            @Override
            public void onStopTrackingTouch(SeekBar seekBar) {

            }
        });
    }
}