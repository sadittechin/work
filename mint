flowchart TD
    A[Start Program] --> B[Program.Main()]
    B --> C[Create CoffeeMachine Object]
    C --> D[Show Menu]

    D --> E{User Select Menu}

    E -->|1| F[MakeBlackCoffee()]
    E -->|2| G[MakeMocha()]
    E -->|3| H[MakeLatte()]
    E -->|4| I[MakeChocolate()]
    E -->|5| J[ShowStock()]
    E -->|6| K[Refill()]
    E -->|0| L[Exit Program]

    F --> M{Ingredients Enough?}
    G --> M
    H --> M
    I --> M

    M -->|Yes| N[Make Drink & Reduce Stock]
    M -->|No| O[Show Not Enough Ingredients]

    N --> D
    O --> D
    J --> D
    K --> D
