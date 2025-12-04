package com.example.kantor_mobile_app;

import android.os.Bundle;
import android.view.View;
import android.widget.AdapterView;
import android.widget.ArrayAdapter;
import android.widget.Button;
import android.widget.EditText;
import android.widget.Spinner;
import android.widget.TextView;
import android.widget.Toast;

import androidx.activity.EdgeToEdge;
import androidx.appcompat.app.AppCompatActivity;
import androidx.core.graphics.Insets;
import androidx.core.view.ViewCompat;
import androidx.core.view.WindowInsetsCompat;

import java.util.Locale;

public class MainActivity extends AppCompatActivity {

    Button convertBtn;
    EditText userInput;
    EditText resultET;
    Spinner currencySpinner;
    ArrayAdapter<CharSequence> adapter;
    String currency;

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

        currencySpinner = findViewById(R.id.currencySpr);
        convertBtn = findViewById(R.id.convertBtn);
        userInput  = findViewById(R.id.userInput);
        resultET = findViewById(R.id.resultET);

        adapter = ArrayAdapter.createFromResource(this, R.array.currencies, android.R.layout.simple_spinner_item);

        adapter.setDropDownViewResource(android.R.layout.simple_spinner_dropdown_item);

        currencySpinner.setAdapter(adapter);


        currencySpinner.setOnItemSelectedListener(new AdapterView.OnItemSelectedListener() {
            @Override
            public void onItemSelected(AdapterView<?> parent, View view, int pos, long id) {
                currency = parent.getItemAtPosition(pos).toString();
            }

            @Override
            public void onNothingSelected(AdapterView<?> adapterView) {

            }
        });

        convertBtn.setOnClickListener(view -> {
            String uInpt = userInput.getText().toString();

            if (userInput.getText().toString().isEmpty()) {
                resultET.setText("0");
                return;
            }

            switch (currency) {
                case "Dolar (USD)":
                    convertCurrency(uInpt, 3.64);
                    break;
                case "Jen (JPN)":
                    convertCurrency(uInpt, 0.023);
                    break;
                case "Euro (EUR)":
                    convertCurrency(uInpt, 4.24);
                    break;
                case "Funt (GBP)":
                    convertCurrency(uInpt, 4.85);
                    break;
                case "Frank (CHF)":
                    convertCurrency(uInpt, 4.52);
                    break;
            }
        });
    }

    private void convertCurrency(String userInput, double price) {
        resultET.setText(String.format("%.2f", Double.parseDouble(userInput) / price));
    }
}