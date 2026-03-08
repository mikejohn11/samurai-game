import random

# Create random bandit encounter when the player visits the tavern
# the bandit should have health and the player can choose to fight or run

def encounter_bandit():
    bandit_health = random.randint(50, 100)
    print(f"A wild bandit appears with {bandit_health} health!")
    while bandit_health > 0:
        print("What will you do?")
        print("1) Fight")
        print("2) Run")
        choice = input("Enter your choice (1-2): ").strip()
        if choice == "1":
            player_damage = random.randint(20, 50)
            bandit_health -= player_damage
            print(f"You deal {player_damage} damage to the bandit.")
        elif choice == "2":
            print("You run away from the bandit.")
            return
        else:
            print("Invalid option, please try again.")
    print("You have defeated the bandit!")

    # simple player health system that starts at 100 and decreases when fighting the bandit
    player_health = 100
    bandit_damage = random.randint(10, 30)
    player_health -= bandit_damage
    print(f"The bandit deals {bandit_damage} damage to you. Your health is now {player_health}.")


def main():
    print("===============================")
    print("   Welcome to Samurai Quest     ")
    print("===============================")
    print()

    while True:
        print("Choose an action:")
        print("1) Visit the dojo")
        print("2) Go to the tavern")
        print("3) Leave the village")
        choice = input("Enter your choice (1-3): ").strip()

        if choice == "1":
            visit_dojo()
        elif choice == "2":
            go_tavern()
        elif choice == "3":
            print("You decide to leave the village. Farewell, samurai!")
            break
        else:
            print("Invalid option, please try again.")
        print()


def visit_dojo():
    print("You head to the dojo. The master nods and offers some training.")


def go_tavern():
    print("You enter the tavern. The smell of sake fills the air and townsfolk chatter.")
    encounter_bandit()


if __name__ == "__main__":
    main()
