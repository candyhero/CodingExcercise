let array be arr
f[i] = max(f[i - 1], 0) + arr[i]
result = max(f[0]..f[n])
where n = size of arr
