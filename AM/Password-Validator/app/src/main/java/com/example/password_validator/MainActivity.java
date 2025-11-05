package com.example.password_validator;

import android.os.Bundle;
import android.util.Log;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.Toast;

import androidx.activity.EdgeToEdge;
import androidx.appcompat.app.AppCompatActivity;
import androidx.core.graphics.Insets;
import androidx.core.view.ViewCompat;
import androidx.core.view.WindowInsetsCompat;

import java.util.ArrayList;
import java.util.Random;

public class MainActivity extends AppCompatActivity {

    Button checkBtn;
    EditText passwordEditText;

    private final char[] NUMBERS_LIST = {'0','1','2','3','4','5','6','7','8','9'};

    private final char[] SPECIAL_CHARACTERS = {'!','@','#','$','%','^','&','<','>','.',':','\'','"','/','\\','_', '+','-'};

    private final String UPPER_LETTERS = "ABCDEFGHIJKLMNOPRSTUQWXYZ";
    private final String LOWER_LETTERS = UPPER_LETTERS.toLowerCase();

    private boolean isHavingNumbers;
    private boolean isHavingSpecialChars;
    private boolean isHavingUpperLetters;

    private boolean isHavingLowerLetters;

    private String examplePasswdHint = "";

    private final Random rng = new Random();

    private void prepareToast(String text, int duration) {
        Toast.makeText(MainActivity.this, text, duration).show();
    }

    private boolean isPasswordLongEnough(String passwd, int minLength) {
        return passwd.length() <= minLength - 1;
    }

    private boolean checkPasswordStrength() {
        final Boolean[] conditions = {!isHavingUpperLetters, !isHavingNumbers, !isHavingSpecialChars, !isHavingLowerLetters};
        final String[] msgs = {"Hasło nie zawiera Dużych liter.", "Hasło nie zawiera Cyfr.", "Hasło nie zawiera specjalnych znaków.", "Hasło nie zawiera małych liter." };

        boolean isGoodPasswd = false;

        for (int i=0; i < conditions.length; i++)
            if (conditions[i]) {
                isGoodPasswd = false;
                prepareToast(msgs[i], Toast.LENGTH_SHORT);
            } else isGoodPasswd = true;

        return isGoodPasswd;
    }

    private boolean validateUserInput(String userInput) {
        if (isPasswordLongEnough(userInput, 1)) {
            prepareToast("Nie podano hasła", Toast.LENGTH_SHORT);
            return false;
        }

        if (isPasswordLongEnough(userInput, 8)) {
            String msg = "Hasło jest krótsze niż 8 znaków. Rozważ większą ilość znaków!";
            prepareToast(msg, Toast.LENGTH_LONG);
            return false;
        }

        return true;
    }
    private void checkPassword(View v) {
        String userPasswd = passwordEditText.getText().toString().trim();

        if (!validateUserInput(userPasswd)) return;

        for(char specialChar : SPECIAL_CHARACTERS) if(userPasswd.indexOf(specialChar) != -1 && !isHavingSpecialChars) isHavingSpecialChars = true;
        for(char number : NUMBERS_LIST) if (userPasswd.indexOf(number) != -1 && !isHavingNumbers) isHavingNumbers = true;
        for(char upperLetter : UPPER_LETTERS.toCharArray()) if (userPasswd.indexOf(upperLetter) != -1 && !isHavingUpperLetters) isHavingUpperLetters = true;
        for (char lowerLetter : LOWER_LETTERS.toCharArray()) if (userPasswd.indexOf(lowerLetter) != -1 && !isHavingLowerLetters) isHavingLowerLetters = true;


        if (checkPasswordStrength())
            prepareToast("Hasło jest wystarczające!", Toast.LENGTH_SHORT);
    }

    private void prepareRandomHintPasswd() {
        String chars = LOWER_LETTERS + UPPER_LETTERS;
        int GOOD_PASSWD_LENGTH = 16;

        for (char specialCharacter : SPECIAL_CHARACTERS) chars += specialCharacter;
        for (int number : NUMBERS_LIST) chars += number;

        for (int i = 0; i <= GOOD_PASSWD_LENGTH; i++)
            examplePasswdHint += chars.charAt(rng.nextInt(chars.length()));
    }

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

        prepareRandomHintPasswd();

        checkBtn = findViewById(R.id.checkBtn);

        passwordEditText = findViewById(R.id.passwordEditText);

        passwordEditText.setHint(examplePasswdHint);

        checkBtn.setOnClickListener(this::checkPassword);
    }
}