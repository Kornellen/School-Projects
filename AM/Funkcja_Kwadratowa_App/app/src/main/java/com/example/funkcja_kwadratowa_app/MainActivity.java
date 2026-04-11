package com.example.funkcja_kwadratowa_app;

import android.os.Bundle;
import android.widget.Button;
import android.widget.EditText;
import android.widget.TextView;
import android.widget.Toast;

import androidx.activity.EdgeToEdge;
import androidx.appcompat.app.AppCompatActivity;
import androidx.core.graphics.Insets;
import androidx.core.view.ViewCompat;
import androidx.core.view.WindowInsetsCompat;

public class MainActivity extends AppCompatActivity {
    EditText aInput, bInput, cInput;
    Button calcBtn;
    TextView deltaLbl, resultLbl, funcLbl;

    double a,b,c;

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

        aInput = findViewById(R.id.a_input);
        bInput = findViewById(R.id.b_input);
        cInput = findViewById(R.id.c_input);

        calcBtn = findViewById(R.id.calc_btn);

        deltaLbl = findViewById(R.id.delta_lbl);
        resultLbl = findViewById(R.id.result_lbl);
        funcLbl = findViewById(R.id.func_lbl);

        calcBtn.setOnClickListener(v -> {
            try {
                a = Double.parseDouble(aInput.getText().toString());
                b = Double.parseDouble(bInput.getText().toString());
                c = Double.parseDouble(cInput.getText().toString());
            } catch (Exception e) {
                Toast.makeText(this, "Wprowadzono niedozwolone dane!", Toast.LENGTH_LONG).show();
                return;
            }

            String func = "f(x) = " + a + "x² + " + b + "x + " + c;
            funcLbl.setText(func);
            b = -b;
            double Δ = Math.pow(b,2) - (4 * a * c);

            deltaLbl.setText("Δ = " + Δ );


            if (Δ < 0) {
                Toast.makeText(this, "Delta jest Ujemna Brak rozwiazania!", Toast.LENGTH_LONG).show();
                resultLbl.setText("Brak rozwiazania!");
                return;
            }

            if (Δ == 0) {
                double result = b / (2 * a);
                resultLbl.setText("x = " + result);
                return;
            }

            double res1 = (b + Math.sqrt(Δ)) / (2*a);
            double res2 = (b - Math.sqrt(Δ)) / (2*a);

            resultLbl.setText("x ∊ {" + String.format("%.4f", res1 < res2  ?  res1 : res2) + ", " + String.format("%.4f", res1 > res2 ? res1 : res2) + "}");
        });

    }
}