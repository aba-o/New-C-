```mermaid
flowchart TD
    A[Start] --> B[Create Videos]
    B --> C[Create Comments]
    C --> D[Add Comments to Videos]
    D --> E[Store Videos in List]
    E --> F[Loop Through Video List]
    F --> G[Display Video Information]
    G --> H[Display Comments]
    H --> I{More Videos?}
    I -->|Yes| F
    I -->|No| J[End]
```