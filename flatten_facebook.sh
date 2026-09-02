#!/usr/bin/env bash
set -euo pipefail

ROOT_PATH="./externals"

# Optional argument override
if [ $# -ge 1 ]; then
  ROOT_PATH="$1"
fi

echo "Starting to flatten .xcframework symlinks in $ROOT_PATH..."
echo

# Find all .xcframework directories
find "$ROOT_PATH" -type d -name "*.xcframework" | while IFS= read -r fw; do
  echo "Processing framework: $fw"

  # Find all symlinks inside the framework
  find "$fw" -type l | while IFS= read -r link; do
    echo "Symlink found: $link"

    # Resolve symlink target (may be relative)
    target_rel="$(readlink "$link")"
    link_dir="$(dirname "$link")"
    target_path="$link_dir/$target_rel"

    if [ ! -e "$target_path" ]; then
      echo "Warning: Target path does not exist: $target_path" >&2
      continue
    fi

    temp_path="${link}.real"

    # Clean up temp path if it exists
    if [ -e "$temp_path" ]; then
      rm -rf "$temp_path"
    fi

    # Copy the real contents
    cp -a "$target_path" "$temp_path"
    echo "Copied target to: $temp_path"

    # Remove symlink
    rm "$link"

    # Replace symlink with real copy
    mv "$temp_path" "$link"
    echo "Replaced symlink with real copy at: $link"
    echo
  done
done

echo "✅ Flattening complete."
