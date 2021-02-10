package templates.sorting;

// low & high are both inclusive / closed interval
public class QuickSort {
    public static void main(String[] args) {
        int[] input = new int[] { 2, -1, -10, 0, 5, -9, 1, 2, 1 };
        for (int i = 0; i < input.length; i++) {
            System.out.print(input[i] + ", ");
        }
        System.out.println();
        
        new QuickSort().sort(input);
        for (int i = 0; i < input.length; i++) {
            System.out.print(input[i] + ", ");
        }
    }

    public void sort(int[] nums) {
        quickSort(nums, 0, nums.length - 1);
    }

    private void quickSort(int[] nums, int low, int high) {
        if (high - low < 2) { 
            if (nums[low] > nums[high]) {
                swap(nums, low, high);
            }
            return; 
        }
        int p = partition(nums, low, high);
        quickSort(nums, low, p);
        quickSort(nums, p + 1, high);
    }

    // guaranteed to have at least 3 elements in [low..high]
    private int partition(int[] nums, int low, int high) {     
        int pivot = getPivotIndex(nums, low, high);
        int pivotValue = nums[pivot];
        int lowPtr = low - 1, highPtr = high + 1;
        while (true) {
            while (nums[++lowPtr] < pivotValue) {}
            while (nums[--highPtr] > pivotValue) {}
            if (lowPtr >= highPtr) return highPtr;
            swap(nums, lowPtr, highPtr);
        }
    }

    private int getPivotIndex(int[] nums, int low, int high) {
        int oneThird = (high - low + 1) / 3;
        int med3Low = med3(nums, low, low + oneThird - 1);
        int med3Mid = med3(nums, low + oneThird, high - oneThird);
        int med3High = med3(nums, high - oneThird + 1, high);
        return med3(nums, med3Low, med3Mid, med3High); 
    }

    // return median index
    private int med3(int[] nums, int low, int high) {
        int mid = (low + high) / 2;
        return med3(nums, low, mid, high);
    }

    private int med3(int[] nums, int a, int b, int c) {
        if ((nums[a] <= nums[b] && nums[b] <= nums[c]) 
            || (nums[a] >= nums[b] && nums[b] >= nums[c])) 
            return b;

        if ((nums[b] <= nums[a] && nums[a] <= nums[c]) 
            || (nums[b] >= nums[a] && nums[a] >= nums[c])) 
            return a;

        return c;
    }

    private void swap(int[] nums, int a, int b) {
        int temp = nums[a];
        nums[a] = nums[b];
        nums[b] = temp;
    }
}
