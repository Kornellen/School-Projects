package com.example.mobilna_galeria_zdjec;

import android.graphics.drawable.Drawable;
import android.os.Bundle;
import android.view.KeyEvent;
import android.view.View;
import android.widget.Button;
import android.widget.CompoundButton;
import android.widget.EditText;
import android.widget.ImageView;
import android.widget.LinearLayout;
import android.widget.Switch;
import android.widget.TextView;

import androidx.activity.EdgeToEdge;
import androidx.annotation.NonNull;
import androidx.appcompat.app.AppCompatActivity;
import androidx.constraintlayout.widget.ConstraintLayout;
import androidx.core.graphics.Insets;
import androidx.core.view.ViewCompat;
import androidx.core.view.WindowInsetsCompat;

import java.util.ArrayList;
import java.util.List;

public class MainActivity extends AppCompatActivity {
    private Button prevBtn, nextBtn;
    private ImageView catImage;
    private int count = 1;
    private EditText imgIdInput;
    private Switch backgroundColorSwitch;

    private LinearLayout mainLayout;

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
        mainLayout = findViewById(R.id.mainLayout);
        nextBtn = findViewById(R.id.nextBtn);
        prevBtn = findViewById(R.id.prevBtn);
        catImage = findViewById(R.id.catImage);
        imgIdInput = findViewById(R.id.imgIdInput);
        backgroundColorSwitch = findViewById(R.id.backgroundColorSwitch);

        nextBtn.setOnClickListener((View v) -> {
            count++;

            if (count > 4) count = 1;

            int newImageId = getResources().getIdentifier("kot" + count, "drawable", getPackageName());

            catImage.setImageResource(newImageId);
        });

        prevBtn.setOnClickListener((View v) -> {
            count--;

            if (count < 1) count = 4;

            int newImageId = getResources().getIdentifier("kot" + count, "drawable", getPackageName());

            catImage.setImageResource(newImageId);
        });

        imgIdInput.setOnEditorActionListener((TextView textV, int i, KeyEvent keyEvent) -> {
                try {
                    int idInput = Integer.parseInt(imgIdInput.getText().toString());

                    if (idInput > 4) idInput = 4;
                    if (idInput < 1) idInput = 1;

                    int photoResId = getResources().getIdentifier("kot" + idInput, "drawable", getPackageName() );

                    catImage.setImageResource(photoResId);
                } catch (Exception e) {
                        System.out.printf(e.getMessage());
                }

                return false;
        });

        backgroundColorSwitch.setOnCheckedChangeListener((CompoundButton cBtn, boolean b) -> {
                int color;

                if (backgroundColorSwitch.isChecked()) {
                    color = getColor(R.color.background_second);
                } else {
                    color = getColor(R.color.primary);
                }

                mainLayout.setBackgroundColor(color);
        });
    }
}