RollABallGame - Development Diary
This project is a 3D ball game developed as a midterm assignment for the Unity course. Below are the steps I followed, the challenges I faced, and how I solved them.

1. Setting Up the Game & Play Area
Created the Stage: I started by creating a "Ground" using a 3D Plane.

Safety Walls: To prevent the player from falling off, I created 4 walls using Cube objects.

The "Wall" Logic: I used Ctrl+C and Ctrl+V to duplicate the walls and adjusted their Scale (specifically set to 20 for length) to perfectly fit the edges of the ground.

2. Moving the Player
Physics: Added a Rigidbody component to the Player (Sphere) to enable physics-based movement.

Scripting: I wrote a PlayerController script. I used Input.GetAxis for Horizontal and Vertical movements and applied force using rb.AddForce.

3. Creating Collectibles & Scoring
Collectibles: Created "PickUp" items (Cubes) and tagged them as "PickUp".

OnTriggerEnter: I used the OnTriggerEnter function to detect when the player hits a collectible.

UI System: I integrated TextMeshPro (TMP) to display the score.

Error Encountered: At first, the UI library was missing in the script.

Fix: Added using TMPro; at the top of the code to recognize the UI elements.

4. Game Over Logic ("You Win!")
Condition: I added a logic where the "You Win!" text appears only after collecting all items (e.g., 12 cubes).

Implementation: Used winTextObject.SetActive(true); inside the SetCountText() function when the count reaches the target.

5. What I Learned & AI Assistance
Learning: I learned how to manage 3D physics, how to use the Rect Tool for UI, and the importance of organizing folders (Scripts, Materials, Scenes).

AI Usage: I used Gemini to troubleshoot my C# code and to optimize the "You Win" logic.

Prompt Example: "How can I check the score and show a 'You Win' text in Unity using TMP?"

Solution: The AI suggested creating a public GameObject for the text and enabling it only when the condition is met.

6. Project Organization
Used a .gitignore file to keep the repository clean from Library and other large temporary files.

Followed a "Scripts", "Materials", "Scenes" folder structure for a professional workflow.