package com.example.todo_list;

import android.os.Bundle;
import android.widget.ArrayAdapter;
import android.widget.Button;
import android.widget.EditText;
import android.widget.ListView;

import androidx.activity.EdgeToEdge;
import androidx.appcompat.app.AppCompatActivity;
import androidx.core.graphics.Insets;
import androidx.core.view.ViewCompat;
import androidx.core.view.WindowInsetsCompat;

import java.util.ArrayList;

public class MainActivity extends AppCompatActivity {
    private EditText newTodoEText;
    private Button addBtn;
    private ListView todosView;
    private ArrayList<String> todos = new ArrayList<>();
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

        todos.add("Zakupy: chleb, masło, ser");
        todos.add("Do zrobienia: obiad, umyć podłogi");
        todos.add("weekend: kino, spacer z psem");

        newTodoEText = findViewById(R.id.newToDOEdit);
        addBtn = findViewById(R.id.addBtn);
        todosView = findViewById(R.id.todos);

        ArrayAdapter<String> arrayAdapter = new ArrayAdapter<String>(this, android.R.layout.simple_list_item_1, todos);

        todosView.setAdapter(arrayAdapter);
        addBtn.setOnClickListener(v -> {
            todos.add(newTodoEText.getText().toString());
            arrayAdapter.notifyDataSetChanged();
       });
    }
}