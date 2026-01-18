using UnityEngine;

namespace namespace_animclip_offset
{
    public class Animacija_za_duhove : MonoBehaviour
    {
        // Možeš ga dodeliti ručno ili automatski na istom GameObject-u
        public Animator animator;

        private void Awake()
        {
            // Ako nije dodeljen u Inspectoru, pokuša da ga uzme sa istog GameObject-a
            if (animator == null)
                animator = GetComponent<Animator>();

            if (animator == null)
            {
                Debug.LogError($"Animator komponenta nije pronađena na '{gameObject.name}'!");
                return;
            }

            PlayAnimationClipOffset();
        }

        private void PlayAnimationClipOffset()
        {
            // Dohvati trenutno aktivne clipove
            AnimatorClipInfo[] clipInfo = animator.GetCurrentAnimatorClipInfo(0);

            if (clipInfo == null || clipInfo.Length == 0)
            {
                Debug.LogWarning($"Animator na '{gameObject.name}' nema aktivnih clipova!");
                return;
            }

            AnimationClip animClip = clipInfo[0].clip;

            if (animClip == null)
            {
                Debug.LogWarning($"Prvi clip Animator-a na '{gameObject.name}' je null!");
                return;
            }

            // Random start time
            float randomTime = Random.Range(0f, animClip.length);

            // Dohvati trenutno stanje animacije
            AnimatorStateInfo stateInfo = animator.GetCurrentAnimatorStateInfo(0);
            int stateHash = stateInfo.shortNameHash;

            // Pokreni animaciju sa random offsetom
            animator.Play(stateHash, 0, randomTime / animClip.length);
        }
    }
}
